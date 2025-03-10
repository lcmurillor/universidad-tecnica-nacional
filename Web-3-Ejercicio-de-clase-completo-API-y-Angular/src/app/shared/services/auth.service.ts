import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { User, UserResponse } from '../models/user.interface';
import { HttpClient } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { catchError, map } from 'rxjs/operators';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  //inyeccion de dependecia
private user = new BehaviorSubject<UserResponse>(null!);
get user$(): Observable<UserResponse>{
  return this.user.asObservable();
}

  constructor(
    private http: HttpClient,
    private router: Router
  ) { }

  login(user: User): Observable<UserResponse | void> {
    return this.http.post<UserResponse>(`${environment.URL}auth/login`, user).pipe(
      map((user: UserResponse) => {
        this.saveLocalStorage(user);
        this.user.next(user);
        return user;
      }),
      catchError((error) => this.handleError(error))
    );
  }

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('role');
    this.router.navigate(['login']);
    this.user.next(null!);
  }

  saveLocalStorage(user: UserResponse) {
    const { message, role, ...rest } = user;
    localStorage.setItem('user', JSON.stringify(rest));
    localStorage.setItem('token', rest.token.toString());
     localStorage.setItem('role', role.toString());
  }

  handleError(error: any): Observable<never> {
    let message = 'error desconocido, contacte con el admin';
    if (error) {
      message = `Errror: ${error.error.message}`;
    }
    throw message;
  }
}

