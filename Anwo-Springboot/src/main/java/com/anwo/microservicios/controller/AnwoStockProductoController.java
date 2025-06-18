package com.anwo.microservicios.controller;

import com.anwo.microservicios.model.AnwoStockProducto;
import com.anwo.microservicios.service.AnwoStockProductoService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/anwo-stock-producto")
public class AnwoStockProductoController {

    private final AnwoStockProductoService service;

    public AnwoStockProductoController(AnwoStockProductoService service) {
        this.service = service;
    }

    // GET /api/anwo-stock
    @GetMapping
    public ResponseEntity<List<AnwoStockProducto>> getAll() {
        List<AnwoStockProducto> lista = service.findAll();
        return ResponseEntity.ok(lista);
    }

    // GET /api/anwo-stock/{nroSerie}
    @GetMapping("/{nroSerie}")
    public ResponseEntity<AnwoStockProducto> getById(@PathVariable String nroSerie) {
        return service.findById(nroSerie)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    // POST /api/anwo-stock
    @PostMapping
    public ResponseEntity<AnwoStockProducto> create(@RequestBody AnwoStockProducto producto) {
        AnwoStockProducto saved = service.save(producto);
        return new ResponseEntity<>(saved, HttpStatus.CREATED);
    }

    // PUT /api/anwo-stock/{nroSerie}
    @PutMapping("/{nroSerie}")
    public ResponseEntity<AnwoStockProducto> update(@PathVariable String nroSerie,
                                                    @RequestBody AnwoStockProducto producto) {
        return service.findById(nroSerie)
                .map(existing -> {
                    producto.setNroserieanwo(nroSerie);
                    AnwoStockProducto updated = service.save(producto);
                    return ResponseEntity.ok(updated);
                })
                .orElse(ResponseEntity.notFound().build());
    }

    // DELETE /api/anwo-stock/{nroSerie}
    @DeleteMapping("/{nroSerie}")
    public ResponseEntity<Void> delete(@PathVariable String nroSerie) {
        return service.findById(nroSerie)
                .map(existing -> {
                    service.deleteById(nroSerie);
                    return new ResponseEntity<Void>(HttpStatus.NO_CONTENT);
                })
                .orElse(ResponseEntity.notFound().build());
    }
}
