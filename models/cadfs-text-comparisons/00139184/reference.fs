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
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(0, -50) * mm, "end": v(10, -50) * mm});
            skLineSegment(sketch, "E1", {"start": v(10, -50) * mm, "end": v(10, -10) * mm});
            skLineSegment(sketch, "E2", {"start": v(10, -10) * mm, "end": v(50, -10) * mm});
            skLineSegment(sketch, "E3", {"start": v(50, -10) * mm, "end": v(50, 10) * mm});
            skLineSegment(sketch, "E4", {"start": v(50, 10) * mm, "end": v(0, 10) * mm});
            skLineSegment(sketch, "E5.MirrorCS", {"start": v(-10, -50) * mm, "end": v(-10, -10) * mm});
            skLineSegment(sketch, "E6.MirrorCS", {"start": v(0, -50) * mm, "end": v(-10, -50) * mm});
            skLineSegment(sketch, "E7.MirrorCS", {"start": v(-50, -10) * mm, "end": v(-50, 10) * mm});
            skLineSegment(sketch, "E8.MirrorCS", {"start": v(-10, -10) * mm, "end": v(-50, -10) * mm});
            skLineSegment(sketch, "E9.MirrorCS", {"start": v(-50, 10) * mm, "end": v(0, 10) * mm});
            skCircle(sketch, "E10", {"center": v(0, 0) * mm, "radius": 2.25 * mm});
            skCircle(sketch, "E11", {"center": v(20, 0) * mm, "radius": 2.25 * mm});
            skCircle(sketch, "E12", {"center": v(40, 0) * mm, "radius": 2.25 * mm});
            skCircle(sketch, "E13", {"center": v(0, -20) * mm, "radius": 2.25 * mm});
            skCircle(sketch, "E14", {"center": v(0, -40) * mm, "radius": 2.25 * mm});
            skCircle(sketch, "E15.MirrorC", {"center": v(-40, 0) * mm, "radius": 2.25 * mm});
            skCircle(sketch, "E16.MirrorC", {"center": v(-20, 0) * mm, "radius": 2.25 * mm});
            skLineSegment(sketch, "E17", {"start": v(-30, -10) * mm, "end": v(-30, 10) * mm});
            skLineSegment(sketch, "E18", {"start": v(30, -10) * mm, "end": v(30, 10) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E6.MirrorCS")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2")])],"isStart":false});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3")])],"isStart":false});
            var Q4;
            Q4=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4"),sQuery(id+"F0.wireOp",EDGE,"E9.MirrorCS")])],"isStart":false});
            var Q5;
            Q5=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7.MirrorCS")])],"isStart":false});
            var Q6;
            Q6=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E8.MirrorCS")])],"isStart":false});
            var Q7;
            Q7=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5.MirrorCS")])],"isStart":false});
            var Q8;
            Q8=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E17")])],"isStart":false});
            var Q9;
            Q9=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E18")])],"isStart":false});
            chamfer(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9]), "width" : 2 * mm, "tangentPropagation" : true});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E15.MirrorC")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E16.MirrorC")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E10")])],"isStart":false});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E11")])],"isStart":false});
            var Q4;
            Q4=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E12")])],"isStart":false});
            var Q5;
            Q5=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E13")])],"isStart":false});
            var Q6;
            Q6=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E14")])],"isStart":false});
            chamfer(context, id + "F3", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6]), "width" : 1.45 * mm, "tangentPropagation" : true});
        }
    });