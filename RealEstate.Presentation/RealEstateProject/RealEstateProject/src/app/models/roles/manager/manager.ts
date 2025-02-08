import { Realtor } from "../realtor/realtor";


export class Manager extends Realtor {
  team: Realtor[] = [];

  constructor(){

    super()
    this.id = '';
    this.realtorName = '',
    this.team = [],
    this.name = '',
    this.email = '';
  }
}
