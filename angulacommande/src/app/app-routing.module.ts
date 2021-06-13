import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddClientComponent } from './ClientCrud/add-client/add-client.component';
import { ClientComponent } from './ClientCrud/client/client.component';
import { CommandeEnteteComponent } from './commande-entete/commande-entete.component';
import { ProduitComponent } from './ProduitCrud/produit/produit.component';

const routes: Routes = [
  /* Client */
  {path:"client", component:ClientComponent},
  {path:"produit", component:ProduitComponent},
  {path:"client/add", component:AddClientComponent},
  {path:"commande/add", component:CommandeEnteteComponent},
];

@NgModule({
  imports: [CommonModule,RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
