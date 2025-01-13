import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
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
];

@NgModule({
  imports: [RouterModule.forRoot(routes), HttpClientModule, ReactiveFormsModule],
  exports: [RouterModule],
  providers: [PropertyService]
})
export class AppRoutingModule { }
