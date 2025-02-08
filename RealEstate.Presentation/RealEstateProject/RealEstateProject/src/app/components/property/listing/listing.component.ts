import { CommonModule } from "@angular/common";
import { Component, OnInit } from "@angular/core";
import { RouterModule } from "@angular/router";
import { forkJoin } from "rxjs";
import { Property } from "../../../models/properties/property";
import { CardsComponent } from "../cards/cards.component";
import { PropertyService } from "../../../service/property/property.service";

@Component({
  selector: 'app-listing',
  standalone: true,
  imports: [CommonModule, CardsComponent, RouterModule],
  templateUrl: './listing.component.html',
  styleUrls: ['./listing.component.css']
})
export class ListingComponent implements OnInit {

  constructor(
    private  service: PropertyService, 
  ) { }

  properties = new Array<Property>();



    ngOnInit() { 
      forkJoin({
        properties: this.service.getProperties(),

      })
      .subscribe(
        ({properties}) =>{
          this.properties = properties;
        }, 
          err => {
                console.log(err)
            },
            () => {
                console.log("Completed")
            });
      }
    }
  