import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Users } from '../models/User.interface';


@Injectable({
  providedIn: 'root'
})
export class NewUserService {

  constructor(
    private http: HttpClient
  ) {}

  save(usuario: Users):Observable<Users>{

    const userToken = localStorage.getItem('token')!;

    return this.http.post<Users>(`${environment.URL}user/new`, usuario,{headers:{'auth':userToken}})
    .pipe(catchError(this.handleError));
  }

  modificar(usuario: Users,id):Observable<Users>{

    const userToken = localStorage.getItem('token')!;
    return this.http.patch<Users>(`${environment.URL}user/update/`+id, usuario,{headers:{'auth':userToken}})
    .pipe(catchError(this.handleError));
  }
  eliminar():void{}
  
  handleError(error: any): Observable<never> {
    let message = 'error desconocido, contacte con el admin';
    if (error) {
      message = `Errror: ${error.error.message}`;
    }
    throw message;
  }
}

