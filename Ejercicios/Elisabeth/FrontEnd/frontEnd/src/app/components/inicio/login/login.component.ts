import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { Usuario } from '../../../models/usuario';
import { LoadingComponent } from '../../../shared/loading/loading.component';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink, LoadingComponent],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  login: FormGroup;
  loading:  boolean = false;

  constructor(private fb: FormBuilder,
    private toastr: ToastrService,
    private router: Router)
    {
    this.login = fb.group({
      usuario: ['', Validators.required],
      password: ['', Validators.required]
    });
  }
  ngOnInit(): void {
  }

  log(): void {
    const usuario: Usuario = {
      nombreUsuario: this.login.value.usuario,
      password: this.login.value.password
    }
    this.loading = true;
    setTimeout(() => {
      this.loading = false;
      if (usuario.nombreUsuario === 'elisabeth' && usuario.password === 'admin123')
      {
        this.login.reset();
        this.router.navigate(['/dashboard'])
      } else{
        this.toastr.error('usuario o contraseña incorrecto', 'Error');
        this.login.reset();
      }
      this.loading= false;
    } , 2000)

    console.log(usuario);

  }
}
