import { Component, OnInit } from '@angular/core';
import { CuestionarioService } from '../../../../../services/cuestionario.service';
import { PasoUnoComponent } from '../paso-uno/paso-uno.component';
import { NuevaPreguntaComponent } from './nueva-pregunta/nueva-pregunta.component';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Pregunta } from '../../../../../models/pregunta';

@Component({
  selector: 'app-paso-dos',
  standalone: true,
  imports: [CommonModule, PasoUnoComponent, NuevaPreguntaComponent],
  templateUrl: './paso-dos.component.html',
  styleUrl: './paso-dos.component.css'
})
export class PasoDosComponent implements OnInit{
  tituloCuestionario: string;
  descripcionCuestionario: string;
  listPreguntas: Pregunta[] = [];

  constructor(private custionarioService: CuestionarioService,
    private router: Router,
    private toastr: ToastrService){
    this.tituloCuestionario = custionarioService.tituloCuestionario;
    this.descripcionCuestionario = custionarioService.descripcionCuestionario;
    this.listPreguntas = [];
  }

  ngOnInit(): void {
    this.tituloCuestionario
    this.descripcionCuestionario
  }

}
