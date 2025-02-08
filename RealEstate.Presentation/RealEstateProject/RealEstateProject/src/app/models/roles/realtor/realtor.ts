import { Property } from "../../properties/property";
import { User } from "../user/user";

export class Realtor extends User {
    realtorName: string;
    properties: Property[] = []; 
  
    constructor() {
        super()
      this.realtorName = '';
    }
}
    