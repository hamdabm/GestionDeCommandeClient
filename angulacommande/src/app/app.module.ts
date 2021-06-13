import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientComponent } from './ClientCrud/client/client.component';
import { ProduitComponent } from './ProduitCrud/produit/produit.component';
import { CommandeEnteteComponent } from './commande-entete/commande-entete.component';
import { CommandeLigneComponent } from './CommandeCrud/commande-ligne/commande-ligne.component';
import { HttpClientModule } from '@angular/common/http';
import { AddClientComponent } from './ClientCrud/add-client/add-client.component';
import { DeleteClientComponent } from './ClientCrud/delete-client/delete-client.component';
import { UpdateComponent } from './update/update.component';
import { SearchClientComponent } from './ClientCrud/search-client/search-client.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    ClientComponent,
    ProduitComponent,
    CommandeEnteteComponent,
    CommandeLigneComponent,
    AddClientComponent,
    DeleteClientComponent,
    UpdateComponent,
    SearchClientComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule ,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
