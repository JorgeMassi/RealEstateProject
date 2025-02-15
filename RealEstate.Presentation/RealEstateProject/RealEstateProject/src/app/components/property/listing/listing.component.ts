import { Component, OnInit } from "@angular/core";
import { CommonModule } from "@angular/common";
import { Property } from "../../../models/properties/property";
import { CardsComponent } from "../cards/cards.component";
import { PropertyService } from "../../../service/property/property.service";

@Component({
  selector: 'app-listing',
  standalone: true,
  imports: [CardsComponent, CommonModule],
  templateUrl: './listing.component.html',
  styleUrls: ['./listing.component.css']
})
export class ListingComponent implements OnInit {

  properties: Property[] = [];

  constructor(private service: PropertyService) {}

  ngOnInit() {
    this.service.getProperties().subscribe({
      next: (data) => this.properties = data,
      error: (err) => console.error("Error fetching properties", err),
      complete: () => console.log("Property fetch completed")
    });
  }
}
