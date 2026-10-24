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
            skLineSegment(sketch, "E0.bottom", {"start": v(27, 22.5) * mm, "end": v(-27, 22.5) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(27, -22.5) * mm, "end": v(-27, -22.5) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(27, 22.5) * mm, "end": v(27, -22.5) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-27, 22.5) * mm, "end": v(-27, -22.5) * mm});
            skPoint(sketch, "E0.middle", {"position": v(0, 0) * mm});
            skLineSegment(sketch, "E1.0", {"start": v(22, 17.5) * mm, "end": v(-22, 17.5) * mm});
            skLineSegment(sketch, "E1.1", {"start": v(22, 17.5) * mm, "end": v(22, -17.5) * mm});
            skLineSegment(sketch, "E1.2", {"start": v(22, -17.5) * mm, "end": v(-22, -17.5) * mm});
            skLineSegment(sketch, "E1.3", {"start": v(-22, 17.5) * mm, "end": v(-22, -17.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1.0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0, Q1]), "depth" : 15 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1.0")}),1.0]])]});
            extrude(context, id + "F2", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "depth" : 25 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : false, "secondDirectionDepth" : 2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F2.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.0"),sQuery(id+"F0.wireOp",EDGE,"E1.3")])]})});
            var Q1;
            Q1=makeQuery(id+"F2.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F2.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.1"),sQuery(id+"F0.wireOp",EDGE,"E1.2")])]})});
            var Q2;
            Q2=makeQuery(id+"F2.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F2.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.0"),sQuery(id+"F0.wireOp",EDGE,"E1.1")])]})});
            var Q3;
            Q3=makeQuery(id+"F2.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F2.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.2"),sQuery(id+"F0.wireOp",EDGE,"E1.3")])]})});
            var Q4;
            Q4=makeQuery(id+"F2.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F2.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.3")])],"isStart":true})});
            var Q5;
            Q5=makeQuery(id+"F2.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F2.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.2")])],"isStart":true})});
            var Q6;
            Q6=makeQuery(id+"F2.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F2.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.0")])],"isStart":true})});
            var Q7;
            Q7=makeQuery(id+"F2.boolean.opBoolean","COPY",EDGE,{"derivedFrom":makeQuery(id+"F2.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.1")])],"isStart":true})});
            fillet(context, id + "F3", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7]), "radius" : 5 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.left")])]});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            var Q4;
            Q4=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false});
            var Q5;
            Q5=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])],"isStart":false});
            var Q6;
            Q6=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.left")])],"isStart":false});
            var Q7;
            Q7=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top")])],"isStart":false});
            var Q8;
            Q8=makeQuery(id+"F2.boolean.opBoolean","INTERSECT",EDGE,{"derivedFrom":[makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom"),sQuery(id+"F0.wireOp",EDGE,"E0.top"),sQuery(id+"F0.wireOp",EDGE,"E0.left"),sQuery(id+"F0.wireOp",EDGE,"E0.right")])],"isStart":false}),makeQuery(id+"F2.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E1.3")])]})]});
            fillet(context, id + "F4", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8]), "radius" : 3 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });