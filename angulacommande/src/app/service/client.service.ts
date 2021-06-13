import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Client } from '../Model/client';
@Injectable({
  providedIn: 'root'
})
export class ClientService {
  url_back_end : string = "http://localhost:5000";
  constructor(private http: HttpClient) { }
  getAllClient():Observable<Client[]>{
    return this.http.get<Client[]>(this.url_back_end+"/api/Client");
  }
  addClient(clientAdd : Client):Observable<Client>{
    return this.http.post<Client>(this.url_back_end+"/api/Client/AddClient",clientAdd);
  }
}
