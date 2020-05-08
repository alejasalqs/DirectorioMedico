import { Component, OnInit } from "@angular/core";
import { Doctor } from "../../../models/Doctor";
import { DoctoresService } from "../../services/doctores.service";
import { ToastrAlertService } from "../../services/toastr-alert.service";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-listado-doctores",
  templateUrl: "./listado-doctores.component.html",
  styleUrls: ["./listado-doctores.component.css"],
})
export class ListadoDoctoresComponent implements OnInit {
  doctores: Doctor[];

  constructor(
    private doctoresService: DoctoresService,
    private toastr: ToastrAlertService,
    private route: ActivatedRoute
  ) {}

  numeroPagina = 1;
  tamanoPagina = 5;

  ngOnInit() {
    this.route.data.subscribe((data) => {
      this.doctores = data["doctores"];
      console.log(this.doctores);
    });
  }
}
