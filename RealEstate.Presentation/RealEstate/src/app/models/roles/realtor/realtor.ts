import { Property } from "../../property/property";
import { Role, User } from "../user/user";


export class Realtor extends User {
    override id: string;
  realtorName: string;
  properties: Property[] = [];

  constructor(
    id: string,
    realtorName: string,
    role: Role = Role.Realtor,
    name?: string,
    email?: string,
    properties?: Property[]
  ) {
    super(id, role, name, email); // Chamando o construtor da classe base (User)
    this.id = id;
    this.realtorName = realtorName;
    this.properties = properties || [];
  }
}
