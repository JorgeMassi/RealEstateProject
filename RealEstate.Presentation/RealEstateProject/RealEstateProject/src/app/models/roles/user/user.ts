export class User {
    id: string;
    name?: string;
    email?: string;
    role: Role;
  
    constructor() {
      this.id = '';
      this.role = Role.RegisteredUser;
      this.name = '';
      this.email = '';
    }
  
}
export enum Role {
    AdminUser = 'AdminUser',
    Broker = 'Broker',
    Manager = 'Manager',
    Realtor = 'Realtor',
    RegisteredUser = 'RegisteredUser',
    UnregisteredUser = 'UnregisteredUser',
  }