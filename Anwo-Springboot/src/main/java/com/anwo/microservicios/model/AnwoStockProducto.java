package com.anwo.microservicios.model;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.Getter;
import lombok.Setter;
import org.hibernate.annotations.Nationalized;

@Getter
@Setter
@Entity
@Table(name = "AnwoStockProducto")
public class AnwoStockProducto {
    @Id
    @Nationalized
    @Column(name = "nroserieanwo", nullable = false, length = 100)
    private String nroserieanwo;

    @Nationalized
    @Column(name = "nomprodanwo", nullable = false, length = 100)
    private String nomprodanwo;

    @Column(name = "precioanwo", nullable = false)
    private Integer precioanwo;

    @Nationalized
    @Column(name = "reservado", nullable = false, length = 1)
    private String reservado;

}