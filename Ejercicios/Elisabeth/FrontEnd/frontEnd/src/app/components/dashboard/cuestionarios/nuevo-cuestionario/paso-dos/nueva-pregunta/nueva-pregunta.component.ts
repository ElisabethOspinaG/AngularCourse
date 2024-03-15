import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
// import { Pregunta } from '../../../../../../models/pregunta';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-nueva-pregunta',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './nueva-pregunta.component.html',
  styleUrl: './nueva-pregunta.component.css'
})
export class NuevaPreguntaComponent {
  nuevaPregunta: FormGroup;
  // pregunta: Pregunta;
  rtaCorrecta = 0;

  constructor( private fb: FormBuilder,
               private router: Router,
               private toastr: ToastrService,){
      this.nuevaPregunta = this.fb.group({
      titulo: ['', Validators.required],
      respuestas: this.fb.array([]),
    })
  }

}
