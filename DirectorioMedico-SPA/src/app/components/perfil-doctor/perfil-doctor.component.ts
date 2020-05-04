import { Component, OnInit } from "@angular/core";
import { DoctoresService } from "../../services/doctores.service";
import { Doctor } from "../../../models/Doctor";
import { ActivatedRoute } from "@angular/router";
import { ToastrAlertService } from "../../services/toastr-alert.service";

@Component({
  selector: "app-perfil-doctor",
  templateUrl: "./perfil-doctor.component.html",
  styleUrls: ["./perfil-doctor.component.css"],
})
export class PerfilDoctorComponent implements OnInit {
  doctor: Doctor;

  constructor(
    private doctoresService: DoctoresService,
    private router: ActivatedRoute,
    private toastr: ToastrAlertService
  ) {
    this.router.params.subscribe((params) => {
      this.CargarInformacion(params["id"]);
    });
  }

  ngOnInit() {}

  CargarInformacion(id: any) {
    this.doctoresService.obtenerDoctoresID(id).subscribe(
      (doctor: Doctor) => {
        this.doctor = doctor;
        console.log(this.doctor);
      },
      (error) => {
        this.toastr.error(error);
      }
    );
  }
}
