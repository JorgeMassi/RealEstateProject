import { Property } from "../../property/property";
import { Realtor } from "../realtor/realtor";
import { Role } from "../user/user";


export class Manager extends Realtor {
  team: Realtor[] = [];

  constructor(
    id: string,
    realtorName: string,
    team?: Realtor[],
    name?: string,
    email?: string,
    properties?: Property[]
  ) {
    super(id, realtorName, Role.Manager, name, email, properties); // Chamando o construtor da classe base (Realtor)
    this.team = team || [];
  }
}
