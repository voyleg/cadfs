FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(0, 88.9) * mm, "end": v(76.2, 88.9) * mm});
            skLineSegment(sketch, "E1", {"start": v(76.2, 88.9) * mm, "end": v(76.2, 44.45) * mm});
            skLineSegment(sketch, "E2", {"start": v(76.2, 44.45) * mm, "end": v(17.37, 44.45) * mm});
            skLineSegment(sketch, "E3", {"start": v(0, 88.9) * mm, "end": v(0, -88.9) * mm, "construction": true});
            skLineSegment(sketch, "E4", {"start": v(-17.37, 0) * mm, "end": v(17.37, 0) * mm, "construction": true});
            skLineSegment(sketch, "E5", {"start": v(17.37, 0) * mm, "end": v(17.37, 44.45) * mm});
            skLineSegment(sketch, "E6.MirrorCS", {"start": v(0, 88.9) * mm, "end": v(-76.2, 88.9) * mm});
            skLineSegment(sketch, "E7.MirrorCS", {"start": v(-76.2, 88.9) * mm, "end": v(-76.2, 44.45) * mm});
            skLineSegment(sketch, "E8.MirrorCS", {"start": v(-17.37, 0) * mm, "end": v(-17.37, 44.45) * mm});
            skLineSegment(sketch, "E9.MirrorCS", {"start": v(-76.2, 44.45) * mm, "end": v(-17.37, 44.45) * mm});
            skLineSegment(sketch, "E10.MirrorCS", {"start": v(0, -88.9) * mm, "end": v(-76.2, -88.9) * mm});
            skLineSegment(sketch, "E11.MirrorCS", {"start": v(-76.2, -88.9) * mm, "end": v(-76.2, -44.45) * mm});
            skLineSegment(sketch, "E12.MirrorCS", {"start": v(-76.2, -44.45) * mm, "end": v(-17.37, -44.45) * mm});
            skLineSegment(sketch, "E13.MirrorCS", {"start": v(-17.37, 0) * mm, "end": v(-17.37, -44.45) * mm});
            skLineSegment(sketch, "E14.MirrorCS", {"start": v(76.2, -44.45) * mm, "end": v(17.37, -44.45) * mm});
            skLineSegment(sketch, "E15.MirrorCS", {"start": v(0, -88.9) * mm, "end": v(76.2, -88.9) * mm});
            skLineSegment(sketch, "E16.MirrorCS", {"start": v(17.37, 0) * mm, "end": v(17.37, -44.45) * mm});
            skLineSegment(sketch, "E17.MirrorCS", {"start": v(76.2, -88.9) * mm, "end": v(76.2, -44.45) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F1", { "sketchPlane" : qUnion([Q0])});
            skArc(sketch, "E18", {"start": v(0, 0) * mm, "mid": v(269.4, -111.6) * mm, "end": v(381, -381) * mm});
            skArc(sketch, "E19", {"start": v(381, -381) * mm, "mid": v(492.6, -650.4) * mm, "end": v(762, -762) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            var Q1;
            Q1=sQuery(id+"F1.wireOp",EDGE,"E18");
            var Q2;
            Q2=sQuery(id+"F1.wireOp",EDGE,"E19");
            sweep(context, id + "F2", {"profiles" : qUnion([Q0]), "path" : qUnion([Q1, Q2])});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            var Q1;
            Q1=sQuery(id+"F1.wireOp",EDGE,"E18");
            var Q2;
            Q2=sQuery(id+"F1.wireOp",EDGE,"E19");
            sweep(context, id + "F3", {"profiles" : qUnion([Q0]), "path" : qUnion([Q1, Q2])});
        }
    });