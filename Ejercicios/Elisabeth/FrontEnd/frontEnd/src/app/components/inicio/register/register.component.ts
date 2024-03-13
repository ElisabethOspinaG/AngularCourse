import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { RegisterUser } from '../../../models/usuario';
import { ToastrService } from 'ngx-toastr';
import { SecurityService } from '../../../services/security.service';
import { LoadingComponent } from '../../../shared/loading/loading.component';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [ CommonModule, FormsModule, ReactiveFormsModule, RouterLink, LoadingComponent],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  // register = new FormGroup({
  //   usuario: new FormControl('', [Validators.required]),
  //   password: new FormControl('', [Validators.required, Validators.minLength(4)]),
  //   confirmPassword: new FormControl('')
  // })

 register: FormGroup;
 loading:  boolean = false;

  constructor(private fb: FormBuilder,
    private toastr: ToastrService,
    private router: Router,
    private security: SecurityService
    ) {
    this.register = this.fb.group({
      nombreUsuario: ['', Validators.required],
      apellidoUsuario: ['', Validators.required],
      usuario: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(4)]],
      confirmPassword: ['']
      }, {validator: this.checkPassword});
  }

  checkPassword(group: FormGroup): any {
    const pass = group.controls['password'].value;
    const confirmPass = group.controls['confirmPassword'].value;
    return pass === confirmPass ? null : { notSame: true};
  }

  registrarUsuario(): void{
    console.log(this.register);

    const registerUser: RegisterUser = {
      Name: this.register.value.nombreUsuario,
      LastName: this.register.value.apellidoUsuario,
      Username: this.register.value.usuario,
      Password: this.register.value.password,

    }
    this.loading = true;

    setTimeout(() => {

      this.loading = false;
      this.security.CreateUser(registerUser).subscribe((result) => {
        if(result == true){
          this.register.reset();
          this.toastr.success('Usuario creado Exitosamente.')
          this.router.navigate(['/login']);
        }else{
          this.toastr.error('Error. el usuario ya existe.');
          // this.register.reset()
        }
      })

    }, 3000);

    console.log("info registerUser", registerUser )
  }
}
