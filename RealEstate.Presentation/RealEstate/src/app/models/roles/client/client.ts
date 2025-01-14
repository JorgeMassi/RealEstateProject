export class Client {
    id: string; 
    name?: string;
    email?: string;
    phoneNumber?: string;
  
    constructor(id: string, name?: string, email?: string, phoneNumber?: string) {
      this.id = id;
      this.name = name;
      this.email = email;
      this.phoneNumber = phoneNumber;
    }
  }
  