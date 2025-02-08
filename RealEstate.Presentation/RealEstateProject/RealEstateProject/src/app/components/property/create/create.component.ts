import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { PropertyService } from '../../../services/property/property.service';
import { Property } from '../../../models/properties/property';

@Component({
  selector: 'app-create',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './create.component.html',
  styleUrl: './create.component.css'
})
export class CreateComponent {
  
  aptForm: FormGroup;

  apt: Property = new Property();
  propertyForm: any;

  constructor(private service: PropertyService, private fb: FormBuilder) {

    this.aptForm = this.fb.group({
      
      typology: ['', Validators.required],
      city: ['', Validators.required],
      description: [''],
      price: ['', Validators.required],
      location: [''],
      features: [''],
      yearBuilt: [''],
      totalArea: [''],
      rooms: [''],
      floors: [''],
      bathrooms: [''],
      garage: [false],
      energyRating: [''],
      condition: ['']
    });
  }

  onSubmit() {
        this.service.create(this.apt);
    }

}
