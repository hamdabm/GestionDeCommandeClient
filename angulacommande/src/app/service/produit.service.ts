
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Produit } from '../Model/produit';
@Injectable({
  providedIn: 'root'
})
export class ProduitService {
 
  url_back_end : string = "http://localhost:5000";
  constructor(private http: HttpClient) { }
  getAllProduit():Observable<Produit[]>{
    return this.http.get<Produit[]>(this.url_back_end+"/api/Produit");
  }
  addproduit(addproduit : Produit):Observable<Produit>{
    return this.http.post<Produit>(this.url_back_end+"/api/Produit/addproduit",addproduit);
  }
}
