import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [ CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
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
  constructor(private fb: FormBuilder) {
    this.register = this.fb.group({
      usuario: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(4)]],
      confirmPassword: ['']
      }, {validator: this.checkPassword});
  }

  ngOnInit(): void {
  }

  registrarUsuario(): void{
    console.log(this.register);
  }

  checkPassword(group: FormGroup): any {
    const pass = group.controls['password'].value;
    const confirmPass = group.controls['confirmPassword'].value;
    return pass === confirmPass ? null : { notSame: true};
  }

}
