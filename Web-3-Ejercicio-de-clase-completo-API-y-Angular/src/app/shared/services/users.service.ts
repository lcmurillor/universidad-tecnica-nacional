import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Usuarios } from '../models/Usuario.interface';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(
    private http: HttpClient
  ) { }

  guardar(usuario: Usuarios): Observable<Usuarios> {
    const userToken = JSON.parse(localStorage.getItem('user')!);
    return this.http.post<Usuarios>(`${environment.URL}​​​​​​​​user/`, usuario,
      { headers: { 'auth': userToken.token } })
      .pipe(catchError(this.handleError));
  }


  modificar(): void { }
  eliminar(): void { }
  consultarTodos(): Observable<Usuarios[]> {
    const userToken = JSON.parse(localStorage.getItem('user')!);
    return this.http.get<Usuarios[]>(`${environment.URL}user/`,
      { headers: { 'auth': userToken.token } })
      .pipe(catchError(this.handleError));
  }
  consultarId(): void { }

  handleError(error: any): Observable<never> {
    let message = 'error desconocido, contacte con el admin';
    if (error) {
      message = `Errror: ${error.error.message}`;
    }
    throw message;
  }
}
