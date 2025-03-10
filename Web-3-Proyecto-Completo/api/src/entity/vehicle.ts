import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, PrimaryGeneratedColumn, Unique } from "typeorm";
import { delivery } from "./delivery";

@Entity()
@Unique(['identity'])
export class vehicle{
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty()  @MaxLength(10) 
    identity: string;

    @Column() @IsNotEmpty() @MaxLength(50)
    mark: string;

    @Column() @IsNotEmpty()  @MaxLength(20)
    model: string;

    @Column() @IsNotEmpty() @MaxLength(20) 
    color: string;

    @Column() @IsNotEmpty() //@IsDate() 
    created_at: string;

    @Column() @IsNotEmpty()  //@IsDate()
    updated_at: string;

    @ManyToOne(type => delivery, delivery => delivery.vehicle)
    delivery: delivery;
}
