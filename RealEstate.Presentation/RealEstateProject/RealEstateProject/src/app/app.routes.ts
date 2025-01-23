import { RouterModule, Routes } from '@angular/router';
import { CardsComponent } from './components/property/cards/cards.component';
import { ListingComponent } from './components/property/listing/listing.component';
import { NgModule } from '@angular/core';
import { HttpClient, HttpClientModule, HttpClientXsrfModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { PropertyService } from './service/property/property.service';

export const routes: Routes = [
    {path: 'listing', component:ListingComponent}, 
    {path: 'cards', component: CardsComponent},
    
  ];
  @NgModule({
    imports: [RouterModule.forRoot(routes), HttpClientXsrfModule, ReactiveFormsModule],
    exports: [RouterModule],
    providers: [PropertyService]
  })
  export class AppRoutingModule { }