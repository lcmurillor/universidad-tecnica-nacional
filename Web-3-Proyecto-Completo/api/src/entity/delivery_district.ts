import { Entity, ManyToOne, PrimaryGeneratedColumn } from "typeorm";
import { delivery } from "./delivery";
import { district } from "./district";

@Entity()
export class delivery_district {
    @PrimaryGeneratedColumn()
    id: number;

    @ManyToOne(type => delivery, delivery => delivery.delivery_district)
    delivery: delivery;

    @ManyToOne(type => district, district => district.delivery_district)
    district: district;

}