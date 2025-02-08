
import { Property } from "../../properties/property";
import { Manager } from "../manager/manager";
import { Realtor } from "../realtor/realtor";

export class Broker extends Manager {
  constructor(
    id: string,
    name: string, 
    team?: Realtor[],
    email?: string,
    properties?: Property[]
  ) {
    super(); 
  }
}
