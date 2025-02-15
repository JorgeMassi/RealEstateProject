import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import {Property, PropertyStatus} from '../../../models/properties/property';

@Component({
  selector: 'app-cards',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.css']
})
export class CardsComponent {

  @Input()
  property!: Property;

  constructor(private router: Router) {}

  navigate(propertyId: string) {
    this.router.navigate(['/property', propertyId]);
  }

  protected readonly PropertyStatus = PropertyStatus;
}
