package com.anwo.microservicios.repository;

import com.anwo.microservicios.model.AnwoStockProducto;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface AnwoStockProductoRepository extends JpaRepository<AnwoStockProducto,String> {

}
