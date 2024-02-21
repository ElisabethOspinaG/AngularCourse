import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { Usuario } from '../../../models/usuario';
import { LoadingComponent } from '../../../shared/loading/loading.component';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [RouterLink,
            CommonModule,
            FormsModule,
            ReactiveFormsModule,
            LoadingComponent,
            ],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  public login: FormGroup;

  constructor(private fb: FormBuilder,
    private toastr: ToastrService,
    private router: Router)
    {
    this.login = this.fb.group({
      usuario: ['', Validators.required],
      password: ['', Validators.required]
    });
  }
  ngOnInit(): void {
  }
  log(): void {
    console.log(this.login);

    const usuario: Usuario = {
      nombreUsuario: this.login.value.usuario,
      password: this.login.value.password
    }
    if (usuario.nombreUsuario === 'truizdiaz' && usuario.password === 'admin123') {
      this.router.navigate(['/dashboard'])
    } else{
      // this.toastr.error('Error de autenticación','Acceso denegado');
      this.toastr.error('usuario o contraseña incorrecto','Error');
    }
    console.log(usuario);

  }
}
