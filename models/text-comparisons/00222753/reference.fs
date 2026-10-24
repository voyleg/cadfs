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
            skLineSegment(sketch, "E0.bottom", {"start": v(250, 600) * mm, "end": v(-250, 600) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(250, -600) * mm, "end": v(-250, -600) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(250, 600) * mm, "end": v(250, -600) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-250, 600) * mm, "end": v(-250, -600) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 300 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1.bottom", {"start": v(-235, 585) * mm, "end": v(235, 585) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(-235, 215) * mm, "end": v(235, 215) * mm});
            skLineSegment(sketch, "E1.left", {"start": v(-235, 585) * mm, "end": v(-235, 215) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(235, 585) * mm, "end": v(235, 215) * mm});
            skPoint(sketch, "E1.middle", {"position": v(0, 400) * mm});
            skPoint(sketch, "E2.middle", {"position": v(0, -96.25) * mm});
            skLineSegment(sketch, "E3.bottom", {"start": v(-235, 185) * mm, "end": v(235, 185) * mm});
            skLineSegment(sketch, "E3.top", {"start": v(-235, -185) * mm, "end": v(235, -185) * mm});
            skLineSegment(sketch, "E3.left", {"start": v(-235, 185) * mm, "end": v(-235, -185) * mm});
            skLineSegment(sketch, "E3.right", {"start": v(235, 185) * mm, "end": v(235, -185) * mm});
            skLineSegment(sketch, "E4.bottom", {"start": v(-235, -215) * mm, "end": v(235, -215) * mm});
            skLineSegment(sketch, "E4.top", {"start": v(-235, -585) * mm, "end": v(235, -585) * mm});
            skLineSegment(sketch, "E4.left", {"start": v(-235, -215) * mm, "end": v(-235, -585) * mm});
            skLineSegment(sketch, "E4.right", {"start": v(235, -215) * mm, "end": v(235, -585) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1.bottom")}),-1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E2.bottom")}),-1.0]])]});
            var Q2;
            Q2=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E3.bottom")}),-1.0]])]});
            var Q3;
            Q3=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E4.bottom")}),-1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 250 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E5", {"center": v(-270, -625) * mm, "radius": 25 * mm});
            skCircle(sketch, "E6", {"center": v(-30, -625) * mm, "radius": 25 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E5")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E6")}),1.0]])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 35 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E7.0", {"center": v(30, -625) * mm, "radius": 25 * mm});
            skCircle(sketch, "E8.0", {"center": v(270, -625) * mm, "radius": 25 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E7.0")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E8.0")}),1.0]])]});
            extrude(context, id + "F7", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 35 * mm});
        }
    });