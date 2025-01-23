import { Appointment } from "../appoiment/appoiment";

export class AdminUser {
  id: number;
  name?: string; 
  calendar: Appointment[] = [];

  constructor(id: number, name?: string, calendar?: Appointment[]) {
    this.id = id;
    this.name = name;
    this.calendar = calendar || []; 
  }
}
