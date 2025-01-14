import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
<<<<<<< HEAD
import { ListingComponent } from './components/property/listing/listing.component';
import { PropertyService } from './services/property/property.service';
import { HttpClientModule } from '@angular/common/http';
import { CardsComponent } from './components/property/cards/cards.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CreateComponent } from './components/property/create/create.component';


export const routes: Routes = [
  {path: 'listing', component:ListingComponent}, 
  {path: 'cards', component: CardsComponent},
  {path: 'create', component: CreateComponent}
=======

import { HttpClientModule } from '@angular/common/http';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';


export const routes: Routes = [
  
>>>>>>> ab31ec056e7902227f1b2e839833b6efedbefb1d
];

@NgModule({
  imports: [RouterModule.forRoot(routes), HttpClientModule, ReactiveFormsModule],
  exports: [RouterModule],
<<<<<<< HEAD
  providers: [PropertyService]
=======
 
>>>>>>> ab31ec056e7902227f1b2e839833b6efedbefb1d
})
export class AppRoutingModule { }
