import { Component, OnInit } from "@angular/core";
import { Doctor } from "../../../models/Doctor";
import { DoctoresService } from "../../services/doctores.service";
import { ToastrAlertService } from "../../services/toastr-alert.service";
import { ActivatedRoute } from "@angular/router";
import { Pagination, PaginatedResult } from "../../../models/pagination";

@Component({
  selector: "app-listado-doctores",
  templateUrl: "./listado-doctores.component.html",
  styleUrls: ["./listado-doctores.component.css"],
})
export class ListadoDoctoresComponent implements OnInit {
  doctores: Doctor[];
  pagination: Pagination;

  constructor(
    private doctoresService: DoctoresService,
    private toastr: ToastrAlertService,
    private route: ActivatedRoute
  ) {}

  numeroPagina = 1;
  tamanoPagina = 5;

  ngOnInit() {
    this.route.data.subscribe((data) => {
      this.doctores = data["doctores"].result;
      this.pagination = data["doctores"].pagination;
      console.log(this.doctores);
      console.log(this.pagination);
    });
  }

  pageChanged(event: any) {
    this.pagination.paginaActual = event.page;
    this.cargarUsuarios();
  }

  cargarUsuarios() {
    this.doctoresService
      .obtenerDoctores(
        this.pagination.paginaActual,
        this.pagination.itemsPorPagina
      )
      .subscribe(
        (res: PaginatedResult<Doctor[]>) => {
          this.doctores = res.result;
          this.pagination = res.pagination;
        },
        (error) => {
          this.toastr.error("Error", "Error");
        }
      );
  }
}
