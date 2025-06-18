package com.anwo.microservicios.service;

import com.anwo.microservicios.model.AnwoStockProducto;
import com.anwo.microservicios.repository.AnwoStockProductoRepository;
import org.springframework.stereotype.Service;
import java.util.List;
import java.util.Optional;

@Service
public class AnwoStockProductoService implements AnwoStockProductoService {
    private final AnwoStockProductoRepository repository;

    public AnwoStockProductoServiceImpl(AnwoStockProductoRepository repository) {
        this.repository = repository;
    }

    @Override
    public List<AnwoStockProducto> findAll() {
        return repository.findAll();
    }

    @Override
    public Optional<AnwoStockProducto> findById(String nroSerie) {
        return repository.findById(nroSerie);
    }

    @Override
    public AnwoStockProducto save(AnwoStockProducto producto) {
        return repository.save(producto);
    }

    @Override
    public void deleteById(String nroSerie) {
        repository.deleteById(nroSerie);
    }
}
