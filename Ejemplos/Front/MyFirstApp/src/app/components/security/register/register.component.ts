import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { User } from '../../../models/user';
import { AnotherModel } from '../../../models/anotherModel';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  registerForm: FormGroup;
  /**
   *
   */
  constructor(fb: FormBuilder) {
    this.registerForm = fb.group({
      name: ["", Validators.required],
      lastName: ["", Validators.required],
      email: ["", Validators.required],
      password: ["", [Validators.required, Validators.minLength(4), Validators.maxLength(16)]],
      repeatPassword: ["", Validators.required],
    },{validator: this.checkPassword} )
  }

  checkPassword(group: FormGroup): any{
    const pass = group.value.password;
    const repeatPass = group.value.repeatPassword;
    return pass == repeatPass ? null : {passwordDifferent: true};
  }

  submit():void{
    console.log(this.registerForm);
    // no datatype.
    const data = {
      email: "",
      password: "",
      test: 'any random info',
      pedro: 1
    };
    
    // user data type.
    const userData: User = {
      email: "pospina",
      password: "aaa"
      // test: "random info" // This gives me error in coding time
    };

    // AnotherModel data type.
    const randomData: AnotherModel = {
      OneProperty: 'some info',
      AnotherProperty: 'more random info ...'
    };
    

    console.log(data);
    console.log(userData);
    this.showData(data);
    this.showData(userData);
    
    // this.showUserData(randomData); // This gives me error in coding time
    // this.showUserData(data); // Error
    this.showUserData(userData);

  }
  
  showData(data: any) {
    console.log(data.test);
    console.log(data.emial);
    console.log(data.pasword);
    console.log(data.whatever);
  }

  showUserData(userData: User) {
    console.log(userData.email);
    console.log(userData.password);
    // console.log(userData.whatever); // Gives me error in coding time !!!
  }
}
