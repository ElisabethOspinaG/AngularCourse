import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {
  FormBuilder,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AnotherModel } from '../../../models/anotherModel';
import { User } from '../../../models/user';
import { LoadingComponent } from '../../shared/loading/loading.component';
import { SecurityService } from '../../../services/security.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, RouterLink, LoadingComponent],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {
  loginForm: FormGroup;
  isLoading: boolean = false;

  constructor(
    private fb: FormBuilder,
    private toastr: ToastrService,
    private router: Router,
    private securityService: SecurityService
  ) {
    this.loginForm = fb.group({
      email: ['', [Validators.required]],
      password: ['', Validators.required],
    });
  }

  Save(): void {
    
    const userData: User = {
      email: this.loginForm.value.email,
      password: this.loginForm.value.password
    };

    this.isLoading = true;

    this.securityService.LogIn(userData).subscribe(result => {
      // Here i can place any code i want.
      console.log(result);
      
      if(result == true){
        console.log("Informacion correcta");
        this.router.navigate(['/admin/dashboard']);
      }else{
        console.log("informacion incorrecta");
        this.toastr.error('Invalid credentials', 'Error!');
        this.toastr.info('Some useful information', 'Information!');
        this.toastr.success('Saved correctly', 'Nice job!');
        this.toastr.warning('Invalid credentials', 'Warning!');
      }
      console.log(result);
    });
    
    
    this.isLoading = false;
  }

}
