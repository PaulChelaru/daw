import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  public url = 'https://localhost:5001/api/client';
  constructor(
    public http: HttpClient
  ) { }
  public getAllClients(): Observable<any>{
    return this.http.get(`${this.url}`);
  }
}