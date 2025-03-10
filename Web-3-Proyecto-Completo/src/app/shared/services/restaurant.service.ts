import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Business } from '../models/Restaurant.interface';


@Injectable({
  providedIn: 'root'
})
export class RestaurantService {

  constructor(
    private http: HttpClient
    ) { }

  getAll():Observable<Business>{

    return this.http.get<Business>(`${environment.URL}bussines/list`)
    .pipe(catchError(this.handleError));
  }

  getOne(id):Observable<Business>{
    const userToken= JSON.parse(localStorage.getItem('token')!); 

    return this.http.get<Business>(`${environment.URL}bussines/`+id,{headers:{'auth':userToken}})
    .pipe(catchError(this.handleError));
  }
  
  save(rest: Business):Observable<Business>{

    const userToken= JSON.parse(localStorage.getItem('token')!); 
    return this.http.post<Business>(`${environment.URL}bussines/new`, rest,{headers:{'auth':userToken}})
    .pipe(catchError(this.handleError));
  }

  modificar(): void { }

  eliminar(): void { }

  handleError(error: any): Observable<never> {
    let message = 'Error desconocido, contacte con el admin';
    if (error) {
      message = `Error: ${error.error.message}`;
    }
    throw message;
  }
}
