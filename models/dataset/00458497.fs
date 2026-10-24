FeatureScript 1549;
import(path : "onshape/std/geometry.fs", version : "1549.0");
import(path : "onshape/std/common.fs", version : "1549.0");
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
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0.bottom", {"start": v(0, 10) * mm, "end": v(12, 10) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(0, 13.5) * mm, "end": v(12, 13.5) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(0, 10) * mm, "end": v(0, 13.5) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(12, 10) * mm, "end": v(12, 13.5) * mm});
            skLineSegment(sketch, "E1.bottom", {"start": v(0, 19.5) * mm, "end": v(12, 19.5) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(0, 23.5) * mm, "end": v(12, 23.5) * mm});
            skLineSegment(sketch, "E1.left", {"start": v(0, 19.5) * mm, "end": v(0, 23.5) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(12, 19.5) * mm, "end": v(12, 23.5) * mm});
            skLineSegment(sketch, "E2", {"start": v(0, 0) * mm, "end": v(48.736561089754105, 0) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1.bottom")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),1.0]])]});
            var Q2;
            Q2=sQuery(id+"F0.wireOp",EDGE,"E2");
            revolve(context, id + "F1", {"entities" : qUnion([Q0, Q1]), "axis" : qUnion([Q2]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            cPlane(context, id + "F2", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 6 * mm, "oppositeDirection" : true, "width" : 150 * mm, "height" : 150 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F2.planeOp",FACE);
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skArc(sketch, "E3", {"start": v(0, 12.5) * mm, "mid": v(4, 16.5) * mm, "end": v(0, 20.5) * mm});
            skLineSegment(sketch, "E4", {"start": v(0, 20.5) * mm, "end": v(0, 12.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F3.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F3.wireOp",EDGE,"E3")}),1.0]])]});
            var Q1;
            Q1=sQuery(id+"F3.wireOp",EDGE,"E4");
            revolve(context, id + "F4", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.opRevolve","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F3.wireOp",EDGE,"E3"),sQuery(id+"F3.wireOp",EDGE,"E4")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opRevolve","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            circularPattern(context, id + "F5", {"operationType" : NewBodyOperationType.ADD, "entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "angle" : 360 * degree, "instanceCount" : 10, "equalSpace" : true});
        }
    });