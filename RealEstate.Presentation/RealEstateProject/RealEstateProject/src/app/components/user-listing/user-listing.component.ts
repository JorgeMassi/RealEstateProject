import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-user-listing',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './user-listing.component.html',
  styleUrl: './user-listing.component.css'
})
export class UserListingComponent {
    constructor(private service: UserService) { }
    users = new Array<User>();
    ngOnInit() {
        this.service.getAll()
        .subscribe(
            data => {
                this.users = data;
            },
            err => {
                console.log(err)
            },
            () => {
                console.log("Completed")
            });
      }
}
