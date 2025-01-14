export enum AppointmentStatus {
    Pending = 'Pending',
    Confirmed = 'Confirmed',
    Completed = 'Completed',
    Cancelled = 'Cancelled'
  }
  
  export class Appointment {
    id: number;
    description?: string;
    startTime: Date;
    endTime: Date;
    status: AppointmentStatus;
  
    constructor(
      id: number,
      startTime: Date,
      endTime: Date,
      status: AppointmentStatus = AppointmentStatus.Pending, 
      description?: string
    ) {
      this.id = id;
      this.startTime = startTime;
      this.endTime = endTime;
      this.status = status;
      this.description = description;
    }
  }
  