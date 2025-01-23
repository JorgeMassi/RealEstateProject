import { Realtor } from "../roles/realtor/realtor";

export class Property {
   
    id: string;
    title: string;
    description?: string;
    location: string;
    image?: string;
    price: number;
    status: PropertyStatus;
    realtorId: Realtor;
  
    constructor() {
      this.id = '';
      this.title = '';
      this.location = '';
      this.price = 0;
      this.status = PropertyStatus.Available
      this.realtorId = new Realtor,
      this.description = '';
      this.image = '';
    }
}
export enum PropertyStatus {
    Available = 'Available',
    Reserved = 'Reserved',
    Sold = 'Sold',
  }