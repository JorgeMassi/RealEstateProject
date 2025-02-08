import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterModule} from '@angular/router';
import { Property } from '../../../models/properties/property';


@Component({
  selector: 'app-cards',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './cards.component.html',
  styleUrl: './cards.component.css'
})
export class CardsComponent {
  
  constructor(private router: RouterModule){}
  
  @Input()
  property!: Property;


  navigate(){
    this.router
  }

}
