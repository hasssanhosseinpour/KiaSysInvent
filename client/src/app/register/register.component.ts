import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  constructor(private accountService: AccountService, private toastr: ToastrService) {}

  ngOnInit(): void {}

  register() {
    if (this.validateForm()) {
      this.accountService.register(this.model).subscribe({
        next: () => {
          this.cancel();
        },
        error: (error) => {
          if (error.error === "Username is taken") {
            this.toastr.error("Username is already taken.");
          } else {
            this.toastr.error("An error occurred while registering.");
          }
        },
      });
    }
  }

  cancel() {
    this.cancelRegister.emit(false);
  }

  private validateForm(): boolean {
    if (!this.model.username || !this.model.password) {
      this.toastr.error('Username and password are required.');
      return false;
    }

    if (this.model.password.length < 4 || this.model.password.length > 8) {
      this.toastr.error('Password should be between 4 and 8 characters.');
      return false;
    }

    // Additional validation rules can be added here

    return true;
  }
}
