import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Person} from '../interfaces/interfaces';
import {Observable} from 'rxjs';
import {environment} from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private http: HttpClient) { }

  getData(): Observable<Person[]>{
    return this.http.get<Person[]>(environment.URL_API + 'api/values')
  }
}
