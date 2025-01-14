export enum Role {
    AdminUser = 'AdminUser',
    Broker = 'Broker',
    Manager = 'Manager',
    Realtor = 'Realtor',
    RegisteredUser = 'RegisteredUser',
    UnregisteredUser = 'UnregisteredUser',
  }
  
  export class User {
    id: string;
    name?: string;
    email?: string;
    role: Role;
  
    constructor(id: string, name?: string, email?: string, role: string | Role = Role.RegisteredUser) {
      this.id = id;
      this.name = name;
      this.email = email;
      this.role = typeof role === 'string' ? Role[role as keyof typeof Role] : role;
    }
}
  