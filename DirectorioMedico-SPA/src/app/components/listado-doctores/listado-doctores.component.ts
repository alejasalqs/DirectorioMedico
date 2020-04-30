import { Component, OnInit } from "@angular/core";
import { Doctor } from "../../../models/Doctor";
import { DoctoresService } from "../../services/doctores.service";

@Component({
  selector: "app-listado-doctores",
  templateUrl: "./listado-doctores.component.html",
  styleUrls: ["./listado-doctores.component.css"],
})
export class ListadoDoctoresComponent implements OnInit {
  doctores: Doctor[];

  constructor(private doctoresService: DoctoresService) {}

  ngOnInit() {
    this.cargarDoctores();
  }

  cargarDoctores() {
    this.doctoresService.obtenerDoctores().subscribe(
      (doctores: Doctor[]) => {
        this.doctores = doctores;
        console.log(this.doctores);
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
