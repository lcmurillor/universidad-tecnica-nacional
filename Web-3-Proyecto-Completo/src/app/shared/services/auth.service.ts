import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject, Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { login, loginResponse } from '../models/Login.Interfece';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  //inyeccion de dependecia
  private user = new BehaviorSubject<loginResponse>(null!);
  get user$(): Observable<loginResponse> {
    return this.user.asObservable();
  }
  constructor(
    private http: HttpClient,
    private router: Router
  ) { }

  login(login: login): Observable<loginResponse | void> {
    return this.http.post<loginResponse>(`${environment.URL}auth/login`, login).pipe(
      map((login: loginResponse) => {
        this.saveLocalStorage(login);
        this.user.next(login);
        return login;
      }),
      catchError((error) => this.handleError(error))
    );
  }

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.router.navigate(['home']);
    this.user.next(null!);
  }

  saveLocalStorage(login: loginResponse) {
    const {token, ...user} = login;
    localStorage.setItem('token', JSON.stringify(token));
    localStorage.setItem('user', JSON.stringify(user));
  }

  handleError(error: any): Observable<never> {
    let message = 'error desconocido, contacte con el admin';
    if (error) {
      message = `Errror: ${error.error.message}`;
    }
    throw message;
  }
}

