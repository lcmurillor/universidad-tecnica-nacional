import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { catchError } from 'rxjs/operators';
import { Episodios } from '../Models/episodios.interface';

@Injectable({
  providedIn: 'root'
})
export class EpisodiosService {

  constructor(
    private http: HttpClient
  ) { }

  getAll(): Observable<Episodios[]>{
    return this.http.get<Episodios[]>(`${environment.URL}episode/`).pipe(catchError(this.handleError))
  }

  handleError(error: any): Observable<never> {
    let message = 'error desconocido, contacte con el admin';
    if (error) {
      message = `Error: ${error.error.message}`;
    }
    throw message;
  }
}
