export enum PropertyStatus {
    Available = 'Available',
    Reserved = 'Reserved',
    Sold = 'Sold',
  }
  
export class Property {
    id: string;
    title?: string;
    description?: string;
    location?: string;
    image?: string;
    price: number;
    status: PropertyStatus;
    realtorId: number;
  
    constructor(
      id: string,
      price: number,
      status: PropertyStatus,
      realtorId: number,
      title?: string,
      description?: string,
      location?: string,
      image?: string
    ) {
      this.id = id;
      this.title = title;
      this.description = description;
      this.location = location;
      this.image = image;
      this.price = price;
      this.status = status;
      this.realtorId = realtorId;
    }
  }
  