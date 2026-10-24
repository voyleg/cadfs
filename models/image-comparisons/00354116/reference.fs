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
            skLineSegment(sketch, "E0", {"start": v(23.17, 0) * mm, "end": v(23.87, 0) * mm});
            skPoint(sketch, "E1.middle", {"position": v(0, 0) * mm});
            skLineSegment(sketch, "E2", {"start": v(-6.35, 6.35) * mm, "end": v(-25.4, 0) * mm});
            skLineSegment(sketch, "E3", {"start": v(0, 25.4) * mm, "end": v(-6.35, 6.35) * mm});
            skLineSegment(sketch, "E4", {"start": v(0, 25.4) * mm, "end": v(6.35, 6.35) * mm});
            skLineSegment(sketch, "E5", {"start": v(6.35, 6.35) * mm, "end": v(23.87, 0) * mm});
            skLineSegment(sketch, "E6", {"start": v(23.54, 0.14) * mm, "end": v(6.35, -6.35) * mm});
            skLineSegment(sketch, "E7", {"start": v(6.35, -6.35) * mm, "end": v(0, -25.4) * mm});
            skLineSegment(sketch, "E8", {"start": v(0, -25.4) * mm, "end": v(-6.35, -6.35) * mm});
            skLineSegment(sketch, "E9", {"start": v(-6.35, -6.35) * mm, "end": v(-25.4, 0) * mm});
            skCircle(sketch, "E10", {"center": v(0, 0) * mm, "radius": 6.18 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E2")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 0.5 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4")])],"isStart":true});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3")])],"isStart":true});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2")])],"isStart":true});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E9")])],"isStart":true});
            var Q4;
            Q4=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E8")])],"isStart":true});
            var Q5;
            Q5=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7")])],"isStart":true});
            var Q6;
            Q6=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E6")])],"isStart":true});
            var Q7;
            Q7=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E5")])],"isStart":true});
            fillet(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7]), "radius" : 5.08 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });