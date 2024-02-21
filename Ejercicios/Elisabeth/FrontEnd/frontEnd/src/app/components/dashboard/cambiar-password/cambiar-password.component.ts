import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-cambiar-password',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './cambiar-password.component.html',
  styleUrl: './cambiar-password.component.css'
})
export class CambiarPasswordComponent {
 cambiarPassword: FormGroup;

 constructor(private fb: FormBuilder){
  this.cambiarPassword = this.fb.group({
    passwordAnterior: ['', Validators.required],
    nuevaPassword: ['', [Validators.required, Validators.minLength(4)]],
    confirmPassword: ['']
  }, {validator: this.checkPassword})
 }

 checkPassword(group: FormGroup): any {
  const pass = group.controls['password'].value;
  const confirmPass = group.controls['confirmPassword'].value;
  return pass === confirmPass ? null : { notSame: true};
}

  guardarPassword(){
    console.log(this.cambiarPassword);

  }
}
