import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Personajes } from '../Models/personajes.interface';

@Injectable({
  providedIn: 'root'
})
export class PersonajesService {

  constructor(
    private http: HttpClient
  ) { }

  getAll(): Observable<Personajes[]>{
    return this.http.get<Personajes[]>(`${environment.URL}character/`).pipe(catchError(this.handleError))
  }

  handleError(error: any): Observable<never> {
    let message = 'error desconocido, contacte con el admin';
    if (error) {
      message = `Error: ${error.error.message}`;
    }
    throw message;
  }
}
