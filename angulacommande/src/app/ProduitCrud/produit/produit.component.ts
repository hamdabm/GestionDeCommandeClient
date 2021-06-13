import { Component, OnInit } from '@angular/core';
import { Produit } from '../../Model/produit';
import { ProduitService } from '../../service/produit.service';

@Component({
  selector: 'app-produit',
  templateUrl: './produit.component.html',
  styleUrls: ['./produit.component.css']
})
export class ProduitComponent implements OnInit {
  tabProduit: Produit[] = [];

  constructor(private produitService: ProduitService) { }

  ngOnInit(): void {
    //this.tabProduit = this.produitService.getAllProduit();
    this.produitService.getAllProduit()
    .subscribe((response) => {
      this.tabProduit = response;
      console.log(response)
    });
  }

}
