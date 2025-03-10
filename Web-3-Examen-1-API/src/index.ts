import "reflect-metadata";
import { createConnection } from "typeorm";
import * as express from "express";
import routes from "./routes";
import cors = require("cors");
import helmet = require("helmet");

const PORT = process.env.PORT || 3000;

createConnection().then(async connection => {

    // create express app
    const app = express();

    app.use(cors());
    app.use(helmet());
    app.use(express.json());

    //Rutas
    app.use('/', routes);

    // start express server
    app.listen(PORT, () => {
        console.log(`Se levanto correctamente el servidor en el puerto: http://localhost:${PORT}/`)
    });

}).catch(error => console.log(error));
