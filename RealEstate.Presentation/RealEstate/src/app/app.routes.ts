import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HttpClientModule } from '@angular/common/http';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';


export const routes: Routes = [
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes), HttpClientModule, ReactiveFormsModule],
  exports: [RouterModule],
 
})
export class AppRoutingModule { }
